USE RichProject

CREATE TABLE MonthAmountSummary   
(
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
TimeFlag NVARCHAR(100),
Amount DECIMAL,
Remark NVARCHAR(1000),
CreationTime DATETIME,
LastModifycationTime DATETIME,
IsDeleted bit
)
GO

--��������
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ÿ�²Ƹ��ܶ�', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary'
GO

--���ֶ�����
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���±��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'TimeFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ע' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'CreationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'LastModifycationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�Ƿ�ɾ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonthAmountSummary', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
