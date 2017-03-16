using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationDetailsMessage : AbstractPartyMessage
	{
		public const uint Id = 6263;

		public sbyte partyType;

		public string partyName;

		public double fromId;

		public string fromName;

		public double leaderId;

		public PartyInvitationMemberInformations[] members;

		public PartyGuestInformations[] guests;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6263;
			}
		}

		public PartyInvitationDetailsMessage()
		{
		}

		public PartyInvitationDetailsMessage(uint partyId, sbyte partyType, string partyName, double fromId, string fromName, double leaderId, PartyInvitationMemberInformations[] members, PartyGuestInformations[] guests) : base(partyId)
		{
			this.partyType = partyType;
			this.partyName = partyName;
			this.fromId = fromId;
			this.fromName = fromName;
			this.leaderId = leaderId;
			this.members = members;
			this.guests = guests;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.partyType = reader.ReadSByte();
			this.partyName = reader.ReadUTF();
			this.fromId = reader.ReadVarUhLong();
			this.fromName = reader.ReadUTF();
			this.leaderId = reader.ReadVarUhLong();
			ushort num = reader.ReadUShort();
			this.members = new PartyInvitationMemberInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.members[i] = new PartyInvitationMemberInformations();
				this.members[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.guests = new PartyGuestInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.guests[j] = new PartyGuestInformations();
				this.guests[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.partyType);
			writer.WriteUTF(this.partyName);
			writer.WriteVarLong(this.fromId);
			writer.WriteUTF(this.fromName);
			writer.WriteVarLong(this.leaderId);
			writer.WriteShort((short)((int)this.members.Length));
			PartyInvitationMemberInformations[] partyInvitationMemberInformationsArray = this.members;
			for (int i = 0; i < (int)partyInvitationMemberInformationsArray.Length; i++)
			{
				partyInvitationMemberInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.guests.Length));
			PartyGuestInformations[] partyGuestInformationsArray = this.guests;
			for (int j = 0; j < (int)partyGuestInformationsArray.Length; j++)
			{
				partyGuestInformationsArray[j].Serialize(writer);
			}
		}
	}
}