using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlaySpellAnimMessage : NetworkMessage
	{
		public const uint Id = 6114;

		public double casterId;

		public uint targetCellId;

		public uint spellId;

		public short spellLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6114;
			}
		}

		public GameRolePlaySpellAnimMessage()
		{
		}

		public GameRolePlaySpellAnimMessage(double casterId, uint targetCellId, uint spellId, short spellLevel)
		{
			this.casterId = casterId;
			this.targetCellId = targetCellId;
			this.spellId = spellId;
			this.spellLevel = spellLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.casterId = reader.ReadVarUhLong();
			this.targetCellId = reader.ReadVarUhShort();
			this.spellId = reader.ReadVarUhShort();
			this.spellLevel = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.casterId);
			writer.WriteVarShort((int)this.targetCellId);
			writer.WriteVarShort((int)this.spellId);
			writer.WriteShort(this.spellLevel);
		}
	}
}