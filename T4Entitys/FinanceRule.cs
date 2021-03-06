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
    /// 实体-FinanceRule 
    /// </summary>
	public partial class FinanceRule
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 楼盘编号
		/// </summary>		
		public long BuildingSysNo { get; set; }
		
		/// <summary>
		/// 规则类型1：收款规则，2：审核规则，3：转佣规则
   
		/// </summary>		
		public int? RuleType { get; set; }
		
		/// <summary>
		/// 规则名称
		/// </summary>		
		public string RuleName { get; set; }
		
		/// <summary>
		/// 认筹金额，转佣金额
		/// </summary>		
		public decimal? Money { get; set; }
		
		/// <summary>
		/// 描述
		/// </summary>		
		public string Description { get; set; }
		
		/// <summary>
		/// 交易性质
		/// </summary>		
		public string TransactionNature { get; set; }
		
		/// <summary>
		/// 付款方式
		/// </summary>		
		public string PayWay { get; set; }
		
		/// <summary>
		/// 付款性质
		/// </summary>		
		public string PayNature { get; set; }
		
		/// <summary>
		/// 是否需要首次审核
		/// </summary>		
		public bool? IsFirstCheck { get; set; }
		
		/// <summary>
		/// 驳回是否审核
		/// </summary>		
		public bool? IsSecondCheck { get; set; }
		
		/// <summary>
		/// 转佣百分比
		/// </summary>		
		public int? Percent { get; set; }
		
		/// <summary>
		/// 生效时间
		/// </summary>		
		public DateTime? EffectiveDate { get; set; }
		
		/// <summary>
		/// 失效时间
		/// </summary>		
		public DateTime? ExpiredDate { get; set; }
		
		/// <summary>
		/// 是否开启0：未开启，1开启
		/// </summary>		
		public bool IsEnable { get; set; }
		
		/// <summary>
		/// 创建时间（入库时间）
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		/// <summary>
		/// 创建人
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 创建人名称
		/// </summary>		
		public string CreateUserName { get; set; }
		
		/// <summary>
		/// 修改时间
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 修改人
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 修改人名称
		/// </summary>		
		public string ModifyUserName { get; set; }
		
		/// <summary>
		/// 是否删除
		/// </summary>		
		public bool IsDelete { get; set; }
		  
    }
}
