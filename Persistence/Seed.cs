using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context,
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            var adminuser = await SeedUsers(userManager, context);
            var countryId = await SeedCountries(context);
            await SeedCities(context, countryId);
            await SeedSpecies(context);
        }

        public static async Task<AppUser> SeedUsers(UserManager<AppUser> userManager, DataContext context)
        {
            if (await userManager.FindByNameAsync
("johndoe") == null)
            {
                var user = new AppUser();
                user.UserName = "johndoe";
                user.Email = "johndoe@localhost.com";

                IdentityResult result = userManager.CreateAsync
                (user, "P@ssw0rd!").Result;


                if (result.Succeeded)
                {
                    var fosterPref = new FosterPreference
                    {
                        MinimumAge = 0,
                        AlreadyHasPets = false,
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        HasExperience = false,
                        ProfileInfoExists = false,
                    };
                    await context.FosterPreferenceDbSet.AddAsync(fosterPref);
                    await context.SaveChangesAsync();
                    var fp = new FosterProfile
                    {
                        AppUserId = user.Id,
                        FosterPreferenceId = fosterPref.Id,
                        Info = null,
                    };
                    await context.FosterProfileDbSet.AddAsync(fp);
                    await context.SaveChangesAsync();

                    // fosterPref.FosterProfileId = fp.Id;
                    // context.FosterPreferenceDbSet.Update(fosterPref);

                    var candidatePref = new CandidatePreference
                    {
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        MaxAge = null,
                        MaxWeight = null,
                        MinAge = null,
                        MinWeight = null,
                        SpeciesId = null
                    };
                    await context.CandidatePreferenceDbSet.AddAsync(candidatePref);
                    await context.SaveChangesAsync();

                    var cp = new CandidateProfile
                    {
                        AppUserId = user.Id,
                        CandidatePreferenceId = candidatePref.Id,
                        Info = null,
                        IsActive = true,
                    };
                    await context.CandidateProfileDbSet.AddAsync(cp);
                    await context.SaveChangesAsync();

                    user.FosterProfileId = fp.Id;
                    user.CandidateProfileId = cp.Id;
                    await userManager.UpdateAsync(user);
                    userManager.AddToRoleAsync(user,
                                        "member").Wait();
                }
            }
            if (await userManager.FindByNameAsync
("janedoe") == null)
            {
                var user = new AppUser();
                user.UserName = "janedoe";
                user.Email = "janedoe@localhost.com";

                IdentityResult result = userManager.CreateAsync
                (user, "P@ssw0rd!").Result;

                if (result.Succeeded)
                {
                    var fosterPref = new FosterPreference
                    {
                        MinimumAge = 0,
                        AlreadyHasPets = false,
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        HasExperience = false,
                        ProfileInfoExists = false,
                    };
                    await context.FosterPreferenceDbSet.AddAsync(fosterPref);
                    await context.SaveChangesAsync();
                    var fp = new FosterProfile
                    {
                        AppUserId = user.Id,
                        FosterPreferenceId = fosterPref.Id,
                        Info = null,
                    };
                    await context.FosterProfileDbSet.AddAsync(fp);

                    var candidatePref = new CandidatePreference
                    {
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        MaxAge = null,
                        MaxWeight = null,
                        MinAge = null,
                        MinWeight = null,
                        SpeciesId = null
                    };
                    await context.CandidatePreferenceDbSet.AddAsync(candidatePref);
                    await context.SaveChangesAsync();

                    var cp = new CandidateProfile
                    {
                        AppUserId = user.Id,
                        CandidatePreferenceId = candidatePref.Id,
                        Info = null,
                        IsActive = true,
                    };
                    await context.CandidateProfileDbSet.AddAsync(cp);
                    await context.SaveChangesAsync();
                    user.FosterProfileId = fp.Id;
                    user.CandidateProfileId = cp.Id;
                    await userManager.UpdateAsync(user);
                    userManager.AddToRoleAsync(user,
                                        "member").Wait();
                }
            }
            if (await userManager.FindByNameAsync
("samueljackson") == null)
            {
                var user = new AppUser();
                user.UserName = "samueljackson";
                user.Email = "samueljackson@localhost.com";

                IdentityResult result = userManager.CreateAsync
                (user, "P@ssw0rd!").Result;

                if (result.Succeeded)
                {
                    var fosterPref = new FosterPreference
                    {
                        MinimumAge = 0,
                        AlreadyHasPets = false,
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        HasExperience = false,
                        ProfileInfoExists = false,
                    };
                    await context.FosterPreferenceDbSet.AddAsync(fosterPref);
                    await context.SaveChangesAsync();
                    var fp = new FosterProfile
                    {
                        AppUserId = user.Id,
                        FosterPreferenceId = fosterPref.Id,
                        Info = null,
                    };
                    await context.FosterProfileDbSet.AddAsync(fp);

                    var candidatePref = new CandidatePreference
                    {
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        MaxAge = null,
                        MaxWeight = null,
                        MinAge = null,
                        MinWeight = null,
                        SpeciesId = null
                    };
                    await context.CandidatePreferenceDbSet.AddAsync(candidatePref);
                    await context.SaveChangesAsync();

                    var cp = new CandidateProfile
                    {
                        AppUserId = user.Id,
                        CandidatePreferenceId = candidatePref.Id,
                        Info = null,
                        IsActive = true,
                    };
                    await context.CandidateProfileDbSet.AddAsync(cp);
                    await context.SaveChangesAsync();
                    user.FosterProfileId = fp.Id;
                    user.CandidateProfileId = cp.Id;
                    await userManager.UpdateAsync(user);
                    userManager.AddToRoleAsync(user,
                                        "member").Wait();
                }
            }
            if (await userManager.FindByNameAsync
("admin") == null)
            {
                var user = new AppUser();
                user.UserName = "admin";
                user.Email = "bahadirdoser@localhost.com";

                IdentityResult result = userManager.CreateAsync
                (user, "P@ssw0rd!").Result;

                if (result.Succeeded)
                {
                    var fosterPref = new FosterPreference
                    {
                        MinimumAge = 0,
                        AlreadyHasPets = false,
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        HasExperience = false,
                        ProfileInfoExists = false,
                    };
                    await context.FosterPreferenceDbSet.AddAsync(fosterPref);
                    var fp = new FosterProfile
                    {
                        AppUserId = user.Id,
                        FosterPreference = fosterPref,
                        Info = null,
                    };
                    await context.FosterProfileDbSet.AddAsync(fp);

                    var candidatePref = new CandidatePreference
                    {
                        FriendlyWithPeople = Domain.Enums.FriendlyWithPeople.NotSure,
                        FriendlyWithPets = Domain.Enums.FriendlyWithPets.NotSure,
                        MaxAge = null,
                        MaxWeight = null,
                        MinAge = null,
                        MinWeight = null,
                        SpeciesId = null
                    };
                    await context.CandidatePreferenceDbSet.AddAsync(candidatePref);

                    var cp = new CandidateProfile
                    {
                        AppUserId = user.Id,
                        CandidatePreference = candidatePref,
                        Info = null,
                        IsActive = true,
                    };
                    await context.CandidateProfileDbSet.AddAsync(cp);
                    await context.SaveChangesAsync();
                    user.FosterProfileId = fp.Id;
                    user.CandidateProfileId = cp.Id;
                    await userManager.UpdateAsync(user);
                    userManager.AddToRoleAsync(user,
                                        "administrator").Wait();
                }
            }
            return userManager.FindByNameAsync
            ("admin").Result;
        }
        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync
                ("administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "administrator";
                IdentityResult roleResult = await roleManager.
                CreateAsync(role);
            }
            if (!roleManager.RoleExistsAsync
                ("member").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "member";
                IdentityResult roleResult = await roleManager.
                CreateAsync(role);
            }
        }

        public static async Task<Guid> SeedCountries(DataContext context)
        {
            var tr = new Country
            {
                Abbreviation = "TR",
                Name = "Türkiye"
            };
            await context.CountryDbSet.AddAsync(tr);

            await context.SaveChangesAsync();
            return tr.Id;
        }
        public static async Task SeedCities(DataContext context, Guid countryId)
        {
            var cityArr = new string[]{
"Adana","Adiyaman","Afyon","Agri","Aksaray","Amasya","Ankara","Antalya","Ardahan","Artvin","Aydin","Balikesir","Bartin","Batman","Bayburt","Bilecik","Bingol","Bitlis","Bolu","Burdur","Bursa","Canakkale","Cankiri","Corum","Denizli","Diyarbakir","Duzce","Edirne","Elazig","Erzincan","Erzurum","Eskisehir","Gaziantep","Giresun","Gumushane","Hakkari","Hatay","Igdir","Isparta","Istanbul","Izmir","Kahramanmaras","Karabuk","Karaman","Kars","Kastamonu","Kayseri","Kilis","Kirikkale","Kirklareli","Kirsehir","Kocaeli","Konya","Kutahya","Malatya","Manisa","Mardin","Mersin","Mugla","Mus","Nevsehir","Nigde","Ordu","Osmaniye","Rize","Sakarya","Samsun","Sanliurfa","Siirt","Sinop","Sirnak","Sivas","Tekirdag","Tokat","Trabzon","Tunceli","Usak","Van","Yalova","Yozgat","Zonguldak"
            };
            foreach (var c in cityArr)
            {
                await context.CityDbSet.AddAsync(new City { CountryId = countryId, Name = c });
            }

            await context.SaveChangesAsync();
        }
        public static async Task SeedSpecies(DataContext context)
        {
            var species = new List<AnimalSpecie>{
                new AnimalSpecie{
                Name = "Kedi",
            },
            new AnimalSpecie{
                Name = "Köpek"
            },
            new AnimalSpecie{
                Name = "Tavşan"
            },
            new AnimalSpecie{
                Name = "Kuş"
            },
           };

            await context.AnimalSpecieDbSet.AddRangeAsync(species);
            await context.SaveChangesAsync();
        }

    }
}