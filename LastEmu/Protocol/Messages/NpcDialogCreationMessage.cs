using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NpcDialogCreationMessage : NetworkMessage
	{
		public const uint Id = 5618;

		public int mapId;

		public int npcId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5618;
			}
		}

		public NpcDialogCreationMessage()
		{
		}

		public NpcDialogCreationMessage(int mapId, int npcId)
		{
			this.mapId = mapId;
			this.npcId = npcId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mapId = reader.ReadInt();
			this.npcId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.mapId);
			writer.WriteInt(this.npcId);
		}
	}
}