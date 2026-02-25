using SportCenter.Core.Entities;
namespace SportCenter.Core;

public interface IUnitOfWork : IDisposable
{
    public Task<IGenericRepository<Gym>> GymRepository { get; }
    public Task<IGenericRepository<GymZone>> GymZoneRepository { get; }
    public Task<IGenericRepository<Payment>> PaymentRepository { get; }
    public Task<IGenericRepository<QRCode>> QRCodeRepository { get; }
    public Task<IGenericRepository<Role>> RoleRepository { get; }
    public Task<IGenericRepository<Subscribtion>> SubscribtionRepository { get; }
    public Task<IGenericRepository<SubscribtionPlan>> SubscribtionPlanRepository { get; }
    public Task<IGenericRepository<SubscribtionZone>> SubscribtionZoneRepository { get; }
    public Task<IGenericRepository<TrainerPlan>> TrainerPlanRepository { get; }
    public Task<IGenericRepository<TrainingSession>> TrainingSessionRepository { get; }
    public Task<IGenericRepository<TrainingStatus>> TrainingStatusRepository { get; }
    public Task<IGenericRepository<User>> UserRepository { get; }
    public Task<IGenericRepository<UserPlan>> UserPlanRepository { get; }
    public Task<IGenericRepository<Zone>> ZoneRepository { get; }
    void SaveAsync();
}