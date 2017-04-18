//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2016-08-03 13:50:23 by jie
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
namespace T4ConsoleApplication.Entities
{	
    /// <summary>
    /// 实体-Customer 
    /// </summary>
	public partial class Customer
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 客户业务编号
		/// </summary>		
		public long PersonSysNo { get; set; }
		
		/// <summary>
		/// 客户姓名
		/// </summary>		
		public string CustomerName { get; set; }
		
		/// <summary>
		/// 手机号
		/// </summary>		
		public string MobilePhone { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Telephone { get; set; }
		
		/// <summary>
		/// 性别(1:未知;2:男;3:女)
		/// </summary>		
		public int? Gender { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string IdentityCardNumber { get; set; }
		
		/// <summary>
		/// 客户证件类型(1:身份证;2:护照;3:台胞证 ;4:居留证;)
		/// </summary>		
		public int? CredentialsType { get; set; }
		
		/// <summary>
		/// 邮箱地址
		/// </summary>		
		public string EmailAddress { get; set; }
		
		/// <summary>
		/// 客户年龄
		/// </summary>		
		public int? Age { get; set; }
		
		/// <summary>
		/// 客户职业
		/// </summary>		
		public string Profession { get; set; }
		
		/// <summary>
		/// 邮编
		/// </summary>		
		public string Postcode { get; set; }
		
		/// <summary>
		/// 客户职务
		/// </summary>		
		public string Post { get; set; }
		
		/// <summary>
		/// 车型
		/// </summary>		
		public string CarType { get; set; }
		
		/// <summary>
		/// 车号
		/// </summary>		
		public string CarNo { get; set; }
		
		/// <summary>
		/// 来访人数
		/// </summary>		
		public int? VisitorsNum { get; set; }
		
		/// <summary>
		/// 家庭人数
		/// </summary>		
		public int? FamilyNum { get; set; }
		
		/// <summary>
		/// 家庭住址省/市
		/// </summary>		
		public string Province { get; set; }
		
		/// <summary>
		/// 家庭住址城市
		/// </summary>		
		public string City { get; set; }
		
		/// <summary>
		/// 家庭住址区域
		/// </summary>		
		public string District { get; set; }
		
		/// <summary>
		/// 家庭地址
		/// </summary>		
		public string Address { get; set; }
		
		/// <summary>
		/// 客户户籍
		/// </summary>		
		public string Census { get; set; }
		
		/// <summary>
		/// 居住条件
		/// </summary>		
		public string LifeCondition { get; set; }
		
		/// <summary>
		/// 居住状况(1:租贷;2:自有;)
		/// </summary>		
		public int? LivingCondition { get; set; }
		
		/// <summary>
		/// 经济能力(1:全款;2:按揭;3:抵押;)
		/// </summary>		
		public int? EconomicCapacity { get; set; }
		
		/// <summary>
		/// 客户婚姻状况(1:单身;2:未婚;3:离婚;)
		/// </summary>		
		public int? MaritalStatus { get; set; }
		
		/// <summary>
		/// 购买动机(1:自用;2:投资;3:自用/投资 皆可;)
		/// </summary>		
		public int? Motivation { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsDelete { get; set; }
		
		/// <summary>
		/// 家庭收入
		/// </summary>		
		public decimal? HouseholdIncome { get; set; }
		
		/// <summary>
		/// 物业套数
		/// </summary>		
		public int? PropertyNum { get; set; }
		
		/// <summary>
		/// 临时存储来电来访时间
		/// </summary>		
		public DateTime? Time { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime RefreshDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public int IsAttention { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public int Source { get; set; }
		  
    }
}
