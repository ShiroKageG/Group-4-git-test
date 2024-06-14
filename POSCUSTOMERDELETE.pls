create or replace Procedure PosCustomerDelete(
    P_CustomerID Customer.CustomerID%Type
)
As
Begin
Delete From Customer Where CustomerID = P_CustomerID;
Commit;
End;