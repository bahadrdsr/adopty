using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
        public DbSet<Asset> AssetDbSet { get; set; }
        public DbSet<AnimalSpecie> AnimalSpecieDbSet { get; set; }
        public DbSet<CandidatePreference> CandidatePreferenceDbSet { get; set; }
        public DbSet<CandidateProfile> CandidateProfileDbSet { get; set; }
        public DbSet<City> CityDbSet { get; set; }
        public DbSet<Conversation> ConversationDbSet { get; set; }
        public DbSet<Country> CountryDbSet { get; set; }
        public DbSet<DislikedCandidate> DislikedCandidateDbSet { get; set; }
        public DbSet<DislikedPost> DislikedPostDbSet { get; set; }
        public DbSet<FosterPost> FosterPostDbSet { get; set; }
        public DbSet<FosterPreference> FosterPreferenceDbSet { get; set; }
        public DbSet<FosterProfile> FosterProfileDbSet { get; set; }
        public DbSet<LikedCandidate> LikedCandidateDbSet { get; set; }
        public DbSet<LikedPost> LikedPostDbSet { get; set; }
        public DbSet<Match> MatchDbSet { get; set; }
        public DbSet<Message> MessageDbSet { get; set; }
        public DbSet<ProfileAsset> ProfileAssetDbSet { get; set; }
        public DbSet<FosterPostAsset> FosterPostAssetDbSet { get; set; }
    }
}