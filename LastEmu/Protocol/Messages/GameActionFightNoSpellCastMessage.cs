using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameActionFightNoSpellCastMessage : NetworkMessage
	{
		public const uint Id = 6132;

		public uint spellLevelId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6132;
			}
		}

		public GameActionFightNoSpellCastMessage()
		{
		}

		public GameActionFightNoSpellCastMessage(uint spellLevelId)
		{
			this.spellLevelId = spellLevelId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellLevelId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.spellLevelId);
		}
	}
}