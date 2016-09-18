// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAccountPrivacyRules : TLObject 
	{
		public TLVector<TLPrivacyRuleBase> Rules { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLAccountPrivacyRules() { }
		public TLAccountPrivacyRules(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AccountPrivacyRules; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Rules = TLFactory.Read<TLVector<TLPrivacyRuleBase>>(from, cache);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x554ABB6F);
			to.WriteObject(Rules, cache);
			to.WriteObject(Users, cache);
			if (cache) WriteToCache(to);
		}
	}
}