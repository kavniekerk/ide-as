using System;
using System.Collections.Generic;
using System.IO;
using Ideas.Scada.Common.Tags;
using LumenWorks.Framework.IO.Csv;
using System.Xml;
	
namespace Ideas.Scada.Common.DataSources
{
	public abstract class DataSource
	{
		private string name;
		private string filePath;
		private DataSourceFileType fileType;
		private DataSourceType type;		
		private TagGroup tags = new TagGroup();
		
		public DataSource ()
		{
			name = "";
			filePath = "";
		}
		
		public DataSource(
			XmlNode node, 
			string projectPath) : this()
		{
			name = node.Attributes["name"].Value;
			filePath = 
				projectPath +
				"datasources" + Path.DirectorySeparatorChar +
				node.Attributes["filename"].Value;
			
			string fileType = node.Attributes["filetype"].Value;	
			this.FileType = ConvertToDataSourceFileType(fileType);
		}
		
		public abstract void Open();
		
		public abstract void Close();
		
		public abstract TagGroup Read();
		
		public abstract void Write(Tag tag);
		
		protected void ReadSourceFile ()
		{
			switch(this.FileType)
			{
				case DataSourceFileType.CSV:
					ReadCSVFile();
					break;
				case DataSourceFileType.None:
					break;
				default:
					throw new Exception("Unknown datasource file type");
			}
		}
		
		private void ReadCSVFile()
		{
			TextReader textReader = new StreamReader(this.FilePath);
			CsvReader csvReader = new CsvReader(textReader, true, ',');
					
			while(csvReader.ReadNextRecord())
			{
				// Convert CSV record to Tag
				Tag tag = new Tag();
				tag.datasource = this.Name;
				tag.name = csvReader["TagName"];
				tag.address = csvReader["Address"];
				tag.datatype = csvReader["DataType"];
				tag.clientaccess = csvReader["ClientAccess"];
				tag.engunits = csvReader["EngUnits"];
				tag.description = csvReader["Description"];
				
            	this.Tags.Add(tag);
			}
		}
		
		public static DataSourceFileType ConvertToDataSourceFileType(string strSourceType)
		{
			switch(strSourceType.ToLower())
			{
				case "csv": 
					return DataSourceFileType.CSV;
				case "none":
					return DataSourceFileType.None;
				default:
					throw new Exception("Unkown server script language: " + strSourceType);
			}		
		}
		
		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}

		public DataSourceType Type {
			get {
				return this.type;
			}
			set {
				type = value;
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
		
			public DataSourceFileType FileType 
		{
			get 
			{
				return this.fileType;
			}
			set 
			{
				fileType = value;
			}
		}		
		
		public TagGroup Tags {
			get {
				return this.tags;
			}
			set {
				tags = value;
			}
		}
	}
	
	public enum DataSourceFileType
	{
		None,
		CSV
	}
}	
		