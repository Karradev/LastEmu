using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DungeonKeyRingUpdateMessage : NetworkMessage
	{
		public const uint Id = 6296;

		public uint dungeonId;

		public bool available;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6296;
			}
		}

		public DungeonKeyRingUpdateMessage()
		{
		}

		public DungeonKeyRingUpdateMessage(uint dungeonId, bool available)
		{
			this.dungeonId = dungeonId;
			this.available = available;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			this.available = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteBoolean(this.available);
		}
	}
}