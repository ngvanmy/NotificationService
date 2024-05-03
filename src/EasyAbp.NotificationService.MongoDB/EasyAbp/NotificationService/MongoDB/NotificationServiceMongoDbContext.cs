using EasyAbp.NotificationService.NotificationInfos;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using EasyAbp.NotificationService.Notifications;
namespace EasyAbp.NotificationService.MongoDB
{
	[ConnectionStringName(NotificationServiceDbProperties.ConnectionStringName)]
    public class NotificationServiceMongoDbContext : AbpMongoDbContext, INotificationServiceMongoDbContext
    {
		/* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */
		public IMongoCollection<Notification> Notifications { get; set; }
		public IMongoCollection<NotificationInfo> NotificationInfos { get; set; }
		protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureNotificationService();
        }
    }
}