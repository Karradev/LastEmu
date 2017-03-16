using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PrismFightDefenderAddMessage : NetworkMessage
	{
		public const uint Id = 5895;

		public uint subAreaId;

		public uint fightId;

		public CharacterMinimalPlusLookInformations defender;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5895;
			}
		}

		public PrismFightDefenderAddMessage()
		{
		}

		public PrismFightDefenderAddMessage(uint subAreaId, uint fightId, CharacterMinimalPlusLookInformations defender)
		{
			this.subAreaId = subAreaId;
			this.fightId = fightId;
			this.defender = defender;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.fightId = reader.ReadVarUhShort();
			this.defender = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
			this.defender.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteVarShort((int)this.fightId);
			writer.WriteShort(this.defender.TypeId);
			this.defender.Serialize(writer);
		}
	}
}