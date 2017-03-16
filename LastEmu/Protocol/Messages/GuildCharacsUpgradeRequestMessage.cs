using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildCharacsUpgradeRequestMessage : NetworkMessage
	{
		public const uint Id = 5706;

		public sbyte charaTypeTarget;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5706;
			}
		}

		public GuildCharacsUpgradeRequestMessage()
		{
		}

		public GuildCharacsUpgradeRequestMessage(sbyte charaTypeTarget)
		{
			this.charaTypeTarget = charaTypeTarget;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.charaTypeTarget = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.charaTypeTarget);
		}
	}
}