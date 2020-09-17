USE RichProject

USE RichProject

CREATE TABLE LargePayDetail   
(
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
PayName NVARCHAR(1000),
Amount DECIMAL,
Remark NVARCHAR(1000),
CreationTime DATETIME,
LastModifycationTime DATETIME,
IsDeleted BIT DEFAULT 0
)
GO

--表本身描述
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'大型支出登记表', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail'
GO

--表字段描述
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'大型支出名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'PayName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'CreationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'LastModifycationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LargePayDetail', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
