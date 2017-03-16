using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NpcGenericActionRequestMessage : NetworkMessage
	{
		public const uint Id = 5898;

		public int npcId;

		public sbyte npcActionId;

		public int npcMapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5898;
			}
		}

		public NpcGenericActionRequestMessage()
		{
		}

		public NpcGenericActionRequestMessage(int npcId, sbyte npcActionId, int npcMapId)
		{
			this.npcId = npcId;
			this.npcActionId = npcActionId;
			this.npcMapId = npcMapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.npcId = reader.ReadInt();
			this.npcActionId = reader.ReadSByte();
			this.npcMapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.npcId);
			writer.WriteSByte(this.npcActionId);
			writer.WriteInt(this.npcMapId);
		}
	}
}