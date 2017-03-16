using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismFightDefenderLeaveMessage : NetworkMessage
	{
		public const uint Id = 5892;

		public uint subAreaId;

		public uint fightId;

		public double fighterToRemoveId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5892;
			}
		}

		public PrismFightDefenderLeaveMessage()
		{
		}

		public PrismFightDefenderLeaveMessage(uint subAreaId, uint fightId, double fighterToRemoveId)
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