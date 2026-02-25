using SportCenter.DAL.Data;
using System.Linq.Expressions;

namespace SportCenter.DAL;
/*
public class UnitOfWork : IUnitOfWork
{
    private bool disposedValue;

    private readonly SportCenterDbContext context;
    private readonly IGenericRepository<Gym>? gymRepository;
    private readonly IGenericRepository<GymZone>? gymZoneRepository;
    private readonly IGenericRepository<Payment>? paymentRepository;
    private readonly IGenericRepository<QRCode>? qRCodeRepository;
    private readonly IGenericRepository<Role>? roleRepository;
    private readonly IGenericRepository<Subscribtion>? subscribtionRepository;
    private readonly IGenericRepository<SubscribtionPlan>? subscribtionPlanRepository;
    private readonly IGenericRepository<SubscribtionZone>? subscribtionZoneRepository;
    private readonly IGenericRepository<TrainerPlan>? trainerPlanRepository;
    private readonly IGenericRepository<TrainingSession>? trainingSessionRepository;
    private readonly IGenericRepository<TrainingStatus>? trainingStatusRepository;
    private readonly IGenericRepository<User>? userRepository;
    private readonly IGenericRepository<UserPlan>? userPlanRepository;
    private readonly IGenericRepository<Zone>? zoneRepository;

    public IGenericRepository<Gym> GymRepository => gymRepository ?? new GenericRepository<Gym>(context);
    public IGenericRepository<GymZone> GymZoneRepository => gymZoneRepository ?? new GenericRepository<GymZone>(context);
    public IGenericRepository<Payment> PaymentRepository => paymentRepository ?? new GenericRepository<Payment>(context);
    public IGenericRepository<QRCode> QRCodeRepository => qRCodeRepository ?? new GenericRepository<QRCode>(context);
    public IGenericRepository<Role> RoleRepository => roleRepository ?? new GenericRepository<Role>(context);
    public IGenericRepository<Subscribtion> SubscribtionRepository => subscribtionRepository ?? new GenericRepository<Subscribtion>(context);
    public IGenericRepository<SubscribtionPlan> SubscribtionPlanRepository => subscribtionPlanRepository ?? new GenericRepository<SubscribtionPlan>(context);
    public IGenericRepository<SubscribtionZone> SubscribtionZoneRepository => subscribtionZoneRepository ?? new GenericRepository<SubscribtionZone>(context);
    public IGenericRepository<TrainerPlan> TrainerPlanRepository => trainerPlanRepository ?? new GenericRepository<TrainerPlan>(context);
    public IGenericRepository<TrainingSession> TrainingSessionRepository => trainingSessionRepository ?? new GenericRepository<TrainingSession>(context);
    public IGenericRepository<TrainingStatus> TrainingStatusRepository => trainingStatusRepository ?? new GenericRepository<TrainingStatus>(context);
    public IGenericRepository<User> UserRepository => userRepository ?? new GenericRepository<User>(context);
    public IGenericRepository<UserPlan> UserPlanRepository => userPlanRepository ?? new GenericRepository<UserPlan>(context);
    public IGenericRepository<Zone> ZoneRepository => zoneRepository ?? new GenericRepository<Zone>(context);
    public UnitOfWork(SportCenterDbContext context)
    {
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        this.context = context;
    }

    public void Save()
    {
        context.SaveChanges();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                context.Dispose();
            }

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
*/