using System;
using System.Linq;
using System.Threading;
using Application.Common.Dtos;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Users.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, CurrentUserDto>
    {
        private readonly DataContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        public RegisterCommandHandler(DataContext context, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator)
        {
            _jwtGenerator = jwtGenerator;
            _userManager = userManager;
            _context = context;
        }
        public async System.Threading.Tasks.Task<CurrentUserDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (await _context.Users.Where(x => x.Email == request.Email).AnyAsync())
                throw new BadRequestException("Email already exists");
            if (await _context.Users.Where(x => x.UserName == request.Email).AnyAsync())
                throw new BadRequestException("UserName already exists");

            var user = new AppUser
            {
                Email = request.Email,
                UserName = request.Username
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            var fosterPref = new FosterPreference
            {
                MinimumAge = 0,
                AlreadyHasPets = false,
                FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                HasExperience = false,
                ProfileInfoExists = false,
            };
            await _context.FosterPreferenceDbSet.AddAsync(fosterPref);
            var fp = new FosterProfile
            {
                AppUserId = user.Id,
                FosterPreference = fosterPref,
                Info = null,
            };
            await _context.FosterProfileDbSet.AddAsync(fp);
            await _context.SaveChangesAsync(cancellationToken);
            if (result.Succeeded)
            {
                return new CurrentUserDto
                {
                    Token = _jwtGenerator.CreateToken(user),
                    Username = user.UserName,
                };
            }

            throw new Exception("Problem creating user");
        }
    }
}