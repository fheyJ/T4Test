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
    /// 实体-HousesFloor 
    /// </summary>
	public partial class HousesFloor
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
		/// 栋座编号
		/// </summary>		
		public long SeatSysNo { get; set; }
		
		/// <summary>
		/// 楼层编号
		/// </summary>		
		public string FloorNo { get; set; }
		
		/// <summary>
		/// 楼层别名
		/// </summary>		
		public string FloorName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 删除标记 
		/// </summary>		
		public bool IsDelete { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		  
    }
}