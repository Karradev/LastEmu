using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HavenBagDailyLoteryMessage : NetworkMessage
	{
		public const uint Id = 6644;

		public string tokenId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6644;
			}
		}

		public HavenBagDailyLoteryMessage()
		{
		}

		public HavenBagDailyLoteryMessage(string tokenId)
		{
			this.tokenId = tokenId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.tokenId = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.tokenId);
		}
	}
}