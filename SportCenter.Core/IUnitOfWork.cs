namespace SportCenter.Core;

public interface IUnitOfWork : IDisposable
{
    public async Task<IGenericRepository<Gym>> GymRepository { get; }
    public async Task<IGenericRepository<GymZone>> GymZoneRepository { get; }
    public async Task<IGenericRepository<Payment>> PaymentRepository { get; }
    public async Task<IGenericRepository<QRCode>> QRCodeRepository { get; }
    public async Task<IGenericRepository<Role>> RoleRepository { get; }
    public async Task<IGenericRepository<Subscribtion>> SubscribtionRepository { get; }
    public async Task<IGenericRepository<SubscribtionPlan>> SubscribtionPlanRepository { get; }
    public async Task<IGenericRepository<SubscribtionZone>> SubscribtionZoneRepository { get; }
    public async Task<IGenericRepository<TrainerPlan>> TrainerPlanRepository { get; }
    public async Task<IGenericRepository<TrainingSession>> TrainingSessionRepository { get; }
    public async Task<IGenericRepository<TrainingStatus>> TrainingStatusRepository { get; }
    public async Task<IGenericRepository<User>> UserRepository { get; }
    public async Task<IGenericRepository<UserPlan>> UserPlanRepository { get; }
    public async Task<IGenericRepository<Zone>> ZoneRepository { get; }
    async Task SaveAsync();
}