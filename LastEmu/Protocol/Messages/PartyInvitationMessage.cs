using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationMessage : AbstractPartyMessage
	{
		public const uint Id = 5586;

		public sbyte partyType;

		public string partyName;

		public sbyte maxParticipants;

		public double fromId;

		public string fromName;

		public double toId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5586;
			}
		}

		public PartyInvitationMessage()
		{
		}

		public PartyInvitationMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId) : base(partyId)
		{
			this.partyType = partyType;
			this.partyName = partyName;
			this.maxParticipants = maxParticipants;
			this.fromId = fromId;
			this.fromName = fromName;
			this.toId = toId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.partyType = reader.ReadSByte();
			this.partyName = reader.ReadUTF();
			this.maxParticipants = reader.ReadSByte();
			this.fromId = reader.ReadVarUhLong();
			this.fromName = reader.ReadUTF();
			this.toId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.partyType);
			writer.WriteUTF(this.partyName);
			writer.WriteSByte(this.maxParticipants);
			writer.WriteVarLong(this.fromId);
			writer.WriteUTF(this.fromName);
			writer.WriteVarLong(this.toId);
		}
	}
}