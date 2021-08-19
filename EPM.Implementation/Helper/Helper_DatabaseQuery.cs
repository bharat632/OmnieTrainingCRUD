using System;
using System.Collections.Generic;
using System.Text;

namespace EPM.Implementation.Helper
{
    public class Helper_DatabaseQuery
    {
        public static string CreateUser = @"insert into Authenticate (UserName , Password , CreatedBy) values (@userName , @password , 1)";

        public static string LoginUser = @"select count(1) from Authenticate where UserName=@UserName and Password=@Password and isActive=1 and isDeleted=0" ;

        public static string CreateEmployee = @"insert into Emp(EmpName , EmpCode , Email , Phone ,  CreatedBy) values (@EmpName , @EmpCode , @Email  , @Phone , 1)";

        public static string ShowEmployee = @"select EmpId , EmpName , EmpCode , Email , Phone from Emp";
    
    }

}
