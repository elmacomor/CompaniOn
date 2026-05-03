
using CompaniOn.Infrastructure.Interfaces;
using CompaniOn.Infrastructure.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace CompaniOn.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public readonly ICountriesRepository CountriesRepository;
        public readonly IPhotosRepository PhotosRepository;
        public readonly IUsersRepository UsersRepository;
        public readonly IGendersRepository GendersRepository;
        public readonly IRolesRepository RolesRepository;
        public readonly IAIConversationsRepository AIConversationsRepository;
        public readonly IHealthProfileRepository HealthProfileRepository;

        public UnitOfWork(
            DatabaseContext databaseContext,
            ICountriesRepository countriesRepository,
            IPhotosRepository photosRepository,
            IUsersRepository usersRepository,
            IGendersRepository gendersRepository,
            IRolesRepository rolesRepository,
            IAIConversationsRepository aIConversationsRepository,
            IHealthProfileRepository healthProfileRepository)
        {
            _databaseContext = databaseContext;

            CountriesRepository = countriesRepository;
            PhotosRepository = photosRepository;
            UsersRepository = usersRepository;
            GendersRepository = gendersRepository;
            RolesRepository = rolesRepository;
            AIConversationsRepository = aIConversationsRepository;
            HealthProfileRepository = healthProfileRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.SaveChangesAsync(cancellationToken);
        }

        public void SaveChanges()
        {
            _databaseContext.SaveChanges();
        }
    }
}
