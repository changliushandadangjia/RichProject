USE RichProject


CREATE TABLE ShareDealDetail
(
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Name NVARCHAR(100),
ShareCode NVARCHAR(100),
StartPrice DECIMAL,
EndPrice DECIMAL,
ShareNumber DECIMAL,
Amount DECIMAL,
Remark NVARCHAR(1000),
BuyTime DATETIME,
SaleTime DATETIME,
CreationTime DATETIME,
LastModifycationTime DATETIME,
IsDeleted bit
)
GO

--表本身描述
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'股票交易详情表', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail'
GO

--表字段描述
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'股票名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'股票编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'ShareCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'买入价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'StartPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卖出价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'EndPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'股数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'ShareNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'净利润' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Remark'

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'购买时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'BuyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卖出时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'SaleTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'CreationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'LastModifycationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
