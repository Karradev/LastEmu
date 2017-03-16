using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyMemberInFightMessage : AbstractPartyMessage
	{
		public const uint Id = 6342;

		public sbyte reason;

		public double memberId;

		public int memberAccountId;

		public string memberName;

		public int fightId;

		public MapCoordinatesExtended fightMap;

		public int timeBeforeFightStart;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6342;
			}
		}

		public PartyMemberInFightMessage()
		{
		}

		public PartyMemberInFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, int fightId, MapCoordinatesExtended fightMap, int timeBeforeFightStart) : base(partyId)
		{
			this.reason = reason;
			this.memberId = memberId;
			this.memberAccountId = memberAccountId;
			this.memberName = memberName;
			this.fightId = fightId;
			this.fightMap = fightMap;
			this.timeBeforeFightStart = timeBeforeFightStart;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.reason = reader.ReadSByte();
			this.memberId = reader.ReadVarUhLong();
			this.memberAccountId = reader.ReadInt();
			this.memberName = reader.ReadUTF();
			this.fightId = reader.ReadInt();
			this.fightMap = new MapCoordinatesExtended();
			this.fightMap.Deserialize(reader);
			this.timeBeforeFightStart = reader.ReadVarShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.reason);
			writer.WriteVarLong(this.memberId);
			writer.WriteInt(this.memberAccountId);
			writer.WriteUTF(this.memberName);
			writer.WriteInt(this.fightId);
			this.fightMap.Serialize(writer);
			writer.WriteVarShort(this.timeBeforeFightStart);
		}
	}
}