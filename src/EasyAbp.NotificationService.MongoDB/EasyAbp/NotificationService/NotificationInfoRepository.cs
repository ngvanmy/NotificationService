using EasyAbp.NotificationService.MongoDB;
using EasyAbp.NotificationService.Notifications;
using System;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace EasyAbp.NotificationService.NotificationInfos
{
	public class NotificationInfoRepository : MongoDbRepository<INotificationServiceMongoDbContext, NotificationInfo, Guid>, INotificationInfoRepository
	{
		public NotificationInfoRepository(IMongoDbContextProvider<INotificationServiceMongoDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}

	public class NotificationRepository : MongoDbRepository<INotificationServiceMongoDbContext, Notification, Guid>, INotificationRepository
	{
		public NotificationRepository(IMongoDbContextProvider<INotificationServiceMongoDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}