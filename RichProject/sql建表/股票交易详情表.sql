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

--��������
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ʊ���������', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail'
GO

--���ֶ�����
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ʊ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ʊ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'ShareCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����۸�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'StartPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����۸�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'EndPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'ShareNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ע' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'Remark'

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'BuyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'SaleTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'CreationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'LastModifycationTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�Ƿ�ɾ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ShareDealDetail', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
