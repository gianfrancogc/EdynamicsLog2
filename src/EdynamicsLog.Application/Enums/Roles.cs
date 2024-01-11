using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Reflection;

namespace EdynamicsLog.Application.Enums
{

    public class Nothing
    {

    }

    //public enum Roles
    //{
    //    [Description("Director")]
    //    SuperAdmin,
    //    [Description("Administrador")]
    //    Admin,
    //    [Description("Vendedor")]
    //    Seller
        
    //}

    //public class EnumsParameters
    //{
    //    public enum License
    //    {
    //        AI,
    //        AIIa,
    //        AIIb,
    //        AIIIa,
    //        AIIIb,
    //        AIIIc,
    //        BI,
    //        BIIa,
    //        BIIb,
    //        BIIc
    //    }

    //    public enum CompanyCategory
    //    {
    //        Restaurant = 1,
    //        Ecommerce = 2,
    //        Servicio = 3,
    //        Otro = 4
    //    }

    //    public enum Voucher
    //    {
    //        Factura = 1,
    //        Boleta = 2
    //    }


    //    public enum RolStore
    //    {
    //        Administrador,
    //        Colaborador,
    //    }


    //    public enum RolEnterprise
    //    {
    //        [Description("Administrador")]
    //        Administrador,
    //        [Description("Invitado")]
    //        Invitado,
    //    }
    //    public enum Message
    //    {
    //        Success,
    //        Warn,
    //        Info,
    //        Error
    //    }
    //    public enum StatusOrder
    //    {
    //        [Description("Generado")]
    //        Generado,
    //        [Description("Preparacion")]
    //        Preparacion,
    //        [Description("Enviado")]
    //        Enviado,
    //        [Description("Finalizado")]
    //        Finalizado,
    //        [Description("Anulado")]
    //        Anulado
    //    }

    //    public enum IncomeType
    //    {
    //        Total,
    //        CompanyTotal,
    //        TeacherTotal
    //    }

    //    public enum PanelMenu
    //    {

    //        Categories,
    //        Users,
    //        Marcas,
    //    }

    //    public enum Ubigeo
    //    {
    //        Departamento,
    //        Provincia,
    //        Distrito
    //    }

    //    public enum Users
    //    {
    //        Usersgeneral,
    //        Customers

    //    }

    //    public enum Pay
    //    {
    //        SI,
    //        NO
    //    }
    //    public enum Gender
    //    {
    //        [Description("Masculino")]
    //        Male,
    //        [Description("Femenino")]
    //        Female
    //    }

    //    public enum Status
    //    {
    //        Enable,
    //        Disable
    //    }

    //    public enum PayMethod
    //    {
    //        Paypal,
    //        Tarjeta,
    //        ToD
    //    }

    //    public enum Bank
    //    {
    //        [Description("Aun en espera")]
    //        PendingAccount,
    //        BCP,
    //        Scotiabank,
    //        Interbank,
    //        BBVA,
    //    }
    //    public enum TypeLog
    //    {
    //        Login,
    //        Logout,
    //        Register

    //    }

    //    public enum MyFilters
    //    {
    //        IsDeleted
    //    }





    //    public static IEnumerable<EnumDescriptionAndValue> GetAllEnumsWithChilds()
    //    {
    //        var enums = new List<EnumDescriptionAndValue>();
    //        var order = 0;

    //        foreach (var type in typeof(EnumsParameters).GetNestedTypes())
    //        {
    //            var parent = new EnumDescriptionAndValue
    //            {
    //                Name = type.Name,
    //                Order = order
    //            };

    //            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
    //            {
    //                var i = 0;
    //                var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

    //                parent.Childs.Add(new EnumDescriptionAndValue
    //                {
    //                    Name = field.Name,
    //                    Value = field.GetRawConstantValue().ToString(),
    //                    Description = attribute == null ? field.Name : attribute.Description,
    //                    Order = i
    //                });

    //                i++;
    //            }

    //            enums.Add(parent);
    //            order++;
    //        }

    //        return enums;
    //    }
    //}

    //public class EnumDescriptionAndValue
    //{
    //    public string Name { get; set; }
    //    public string Value { get; set; }
    //    public string Description { get; set; }
    //    public int Order { get; set; }
    //    public List<EnumDescriptionAndValue> Childs { get; set; }

    //    public EnumDescriptionAndValue()
    //    {
    //        Childs = new List<EnumDescriptionAndValue>();
    //    }
    //}
}
