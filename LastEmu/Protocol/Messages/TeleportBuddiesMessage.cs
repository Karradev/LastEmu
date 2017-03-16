using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportBuddiesMessage : NetworkMessage
	{
		public const uint Id = 6289;

		public uint dungeonId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6289;
			}
		}

		public TeleportBuddiesMessage()
		{
		}

		public TeleportBuddiesMessage(uint dungeonId)
		{
			this.dungeonId = dungeonId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
		}
	}
}