using System.Collections.Generic;
using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class CurrentUserDto
    {
        public CurrentUserDto()
        {
            Roles = new List<string>();
            Claims = new List<string>();
        }
        public string Token { get; set; }
        public string Username { get; set; }
        public IList<string> Claims { get; private set; }
        public IList<string> Roles { get; private set; }

    }
}