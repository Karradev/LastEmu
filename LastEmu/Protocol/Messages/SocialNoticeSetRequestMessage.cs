using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SocialNoticeSetRequestMessage : NetworkMessage
	{
		public const uint Id = 6686;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6686;
			}
		}

		public SocialNoticeSetRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}