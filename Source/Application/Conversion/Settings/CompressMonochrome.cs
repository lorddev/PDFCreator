using pdfforge.DataStorage;
using pdfforge.PDFCreator.Conversion.Settings.Enums;
using System.Text;
using System;

// ! This file is generated automatically.
// ! Do not edit it outside the sections for custom code.
// ! These changes will be deleted during the next generation run

namespace pdfforge.PDFCreator.Conversion.Settings
{
	/// <summary>
	/// Compression settings for monochrome images
	/// </summary>
	public class CompressMonochrome {
		
		/// <summary>
		/// Settings for the compression method. Valid values are: CcittFaxEncoding, Zip, RunLengthEncoding
		/// </summary>
		public CompressionMonochrome Compression { get; set; }
		
		/// <summary>
		/// Images will be resampled to this maximum resolution of the images, if resampling is enabled
		/// </summary>
		public int Dpi { get; set; }
		
		/// <summary>
		/// If true, monochrome images will be processed according to the algorithm. If false, they will remain uncompressed
		/// </summary>
		public bool Enabled { get; set; }
		
		/// <summary>
		/// If true, the images will be resampled to a maximum resolution
		/// </summary>
		public bool Resampling { get; set; }
		
		
		private void Init() {
			Compression = CompressionMonochrome.CcittFaxEncoding;
			Dpi = 1200;
			Enabled = true;
			Resampling = false;
		}
		
		public CompressMonochrome()
		{
			Init();
		}
		
		public void ReadValues(Data data, string path)
		{
			try { Compression = (CompressionMonochrome) Enum.Parse(typeof(CompressionMonochrome), data.GetValue(@"" + path + @"Compression")); } catch { Compression = CompressionMonochrome.CcittFaxEncoding;}
			try { Dpi = int.Parse(data.GetValue(@"" + path + @"Dpi"), System.Globalization.CultureInfo.InvariantCulture); } catch { Dpi = 1200;}
			try { Enabled = bool.Parse(data.GetValue(@"" + path + @"Enabled")); } catch { Enabled = true;}
			try { Resampling = bool.Parse(data.GetValue(@"" + path + @"Resampling")); } catch { Resampling = false;}
		}
		
		public void StoreValues(Data data, string path)
		{
			data.SetValue(@"" + path + @"Compression", Compression.ToString());
			data.SetValue(@"" + path + @"Dpi", Dpi.ToString(System.Globalization.CultureInfo.InvariantCulture));
			data.SetValue(@"" + path + @"Enabled", Enabled.ToString());
			data.SetValue(@"" + path + @"Resampling", Resampling.ToString());
		}
		
		public CompressMonochrome Copy()
		{
			CompressMonochrome copy = new CompressMonochrome();
			
			copy.Compression = Compression;
			copy.Dpi = Dpi;
			copy.Enabled = Enabled;
			copy.Resampling = Resampling;
			
			return copy;
		}
		
		public override bool Equals(object o)
		{
			if (!(o is CompressMonochrome)) return false;
			CompressMonochrome v = o as CompressMonochrome;
			
			if (!Compression.Equals(v.Compression)) return false;
			if (!Dpi.Equals(v.Dpi)) return false;
			if (!Enabled.Equals(v.Enabled)) return false;
			if (!Resampling.Equals(v.Resampling)) return false;
			
			return true;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine("Compression=" + Compression.ToString());
			sb.AppendLine("Dpi=" + Dpi.ToString());
			sb.AppendLine("Enabled=" + Enabled.ToString());
			sb.AppendLine("Resampling=" + Resampling.ToString());
			
			return sb.ToString();
		}
		
		public override int GetHashCode()
		{
			// ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
			return base.GetHashCode();
		}
		
// Custom Code starts here
// START_CUSTOM_SECTION:GENERAL

// END_CUSTOM_SECTION:GENERAL
// Custom Code ends here. Do not edit below
		
	}
}
