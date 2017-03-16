using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismFightAttackerRemoveMessage : NetworkMessage
	{
		public const uint Id = 5897;

		public uint subAreaId;

		public uint fightId;

		public double fighterToRemoveId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5897;
			}
		}

		public PrismFightAttackerRemoveMessage()
		{
		}

		public PrismFightAttackerRemoveMessage(uint subAreaId, uint fightId, double fighterToRemoveId)
		{
			this.subAreaId = subAreaId;
			this.fightId = fightId;
			this.fighterToRemoveId = fighterToRemoveId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.fightId = reader.ReadVarUhShort();
			this.fighterToRemoveId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteVarShort((int)this.fightId);
			writer.WriteVarLong(this.fighterToRemoveId);
		}
	}
}