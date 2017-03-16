using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PrismFightAttackerAddMessage : NetworkMessage
	{
		public const uint Id = 5893;

		public uint subAreaId;

		public uint fightId;

		public CharacterMinimalPlusLookInformations attacker;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5893;
			}
		}

		public PrismFightAttackerAddMessage()
		{
		}

		public PrismFightAttackerAddMessage(uint subAreaId, uint fightId, CharacterMinimalPlusLookInformations attacker)
		{
			this.subAreaId = subAreaId;
			this.fightId = fightId;
			this.attacker = attacker;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.fightId = reader.ReadVarUhShort();
			this.attacker = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
			this.attacker.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteVarShort((int)this.fightId);
			writer.WriteShort(this.attacker.TypeId);
			this.attacker.Serialize(writer);
		}
	}
}