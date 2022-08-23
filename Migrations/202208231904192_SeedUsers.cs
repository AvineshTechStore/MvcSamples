namespace MvcLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'43a7eeac-2dd7-42d3-84cd-8f0ddfe09697', N'avineshgupta@gmail.com', 0, N'ALxxi+Zy/W89NtaU8d7gFwTcWmyGT1dw6UOOS69XhtgTZV7a1yC/HPkLRIGuYdh0GQ==', N'2a4a71cd-9431-4185-8865-56d0bc77dbbe', NULL, 0, 0, NULL, 1, 0, N'avineshgupta@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bad33ad7-393f-433f-8ece-5087a3e4626d', N'admin@gmail.com', 0, N'AJR1cL+Cc/yzC3yHzjzGzEgXlfh6h6YRlSgqRsXWO4G8Sbm/aQv1/3o1XXhh0+mIPw==', N'3363a581-a3e4-4d14-8094-d5e3dbd229b1', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd25e569-164a-4bba-826f-6931a6c455aa', N'guest@gmail.com', 0, N'AGXkpThDjvrVy5IzaJF0RVS2MV9Z3wZpJirou5mjjNxM4dpIwh+B5cb9yvzwKl4/UA==', N'904b84d5-996c-4859-b69c-cbf15caff59d', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2ab05625-b122-4914-b16c-60e8e981aea9', N'CanManageCustomers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bad33ad7-393f-433f-8ece-5087a3e4626d', N'2ab05625-b122-4914-b16c-60e8e981aea9')

");
        }
        
        public override void Down()
        {
        }
    }
}
