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
    /// 实体-QuestionAnswer 
    /// </summary>
	public partial class QuestionAnswer
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 模板编号
		/// </summary>		
		public long InTemplateSysNo { get; set; }
		
		/// <summary>
		/// 楼盘编号
		/// </summary>		
		public long BuildingSysNo { get; set; }
		
		/// <summary>
		/// 答题人
		/// </summary>		
		public long AnswerSysNo { get; set; }
		
		/// <summary>
		/// 答题姓名
		/// </summary>		
		public string AnswerName { get; set; }
		
		/// <summary>
		/// 答题时间
		/// </summary>		
		public DateTime AnswerTime { get; set; }
		
		/// <summary>
		/// 答案字符串集合
		/// </summary>		
		public string AnswerStringList { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
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
		public string ModifyUserName { get; set; }
		
		/// <summary>
		/// 
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
