using System;
using System.Xml;
using System.IO;
using ideas.common;
using System.Collections.Generic;

namespace ideas.common
{
	public class IdeasScadaTagsDataBase
	{
		private string name;
		private string filePath;
		private IdeasScadaTagsDataBaseSourceType sourceType;
		
		/// <summary>
		/// Constructs the class
		/// </summary>	
		public IdeasScadaTagsDataBase ()
		{
			
		}
			
		
		#region P R O P E R T I E S
		
		public string Name 
		{
			get 
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		public string FilePath 
		{
			get 
			{
				return this.filePath;
			}
			set
			{
				this.filePath = value;
			}
		}
		
		public IdeasScadaTagsDataBaseSourceType SourceType 
		{
			get 
			{
				return this.sourceType;
			}
			set 
			{
				sourceType = value;
			}
		}		
		
		#endregion
		
		public static IdeasScadaTagsDataBaseSourceType convertSourceTypeFromString(string strSourceType)
		{
			switch(strSourceType.ToLower())
			{
				case "csv": 
					return IdeasScadaTagsDataBaseSourceType.CSV;
				default:
					throw new Exception("Unkown server script language: " + strSourceType);
			}		
		}
	}
	
		
	public enum IdeasScadaTagsDataBaseSourceType
	{
		CSV
	}
	
}
