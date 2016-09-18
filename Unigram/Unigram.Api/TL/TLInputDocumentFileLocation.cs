// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputDocumentFileLocation : TLInputFileLocationBase 
	{
		public Int32 Version { get; set; }

		public TLInputDocumentFileLocation() { }
		public TLInputDocumentFileLocation(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputDocumentFileLocation; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Version = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x430F0724);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Version);
			if (cache) WriteToCache(to);
		}
	}
}