using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameActionFightCastRequestMessage : NetworkMessage
	{
		public const uint Id = 1005;

		public uint spellId;

		public short cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1005;
			}
		}

		public GameActionFightCastRequestMessage()
		{
		}

		public GameActionFightCastRequestMessage(uint spellId, short cellId)
		{
			this.spellId = spellId;
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadVarUhShort();
			this.cellId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.spellId);
			writer.WriteShort(this.cellId);
		}
	}
}