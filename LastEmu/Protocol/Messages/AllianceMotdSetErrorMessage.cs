using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
	{
		public const uint Id = 6683;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6683;
			}
		}

		public AllianceMotdSetErrorMessage()
		{
		}

		public AllianceMotdSetErrorMessage(sbyte reason) : base(reason)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}