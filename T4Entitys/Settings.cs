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
    /// 实体-Settings 
    /// </summary>
	public partial class Settings
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Key { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Value { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long? ParentSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public int? Sort { get; set; }
		  
    }
}
