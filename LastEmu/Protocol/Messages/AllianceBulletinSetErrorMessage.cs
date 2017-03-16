using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AllianceBulletinSetErrorMessage : SocialNoticeSetErrorMessage
	{
		public const uint Id = 6692;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6692;
			}
		}

		public AllianceBulletinSetErrorMessage()
		{
		}

		public AllianceBulletinSetErrorMessage(sbyte reason) : base(reason)
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