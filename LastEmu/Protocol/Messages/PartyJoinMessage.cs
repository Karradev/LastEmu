using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyJoinMessage : AbstractPartyMessage
	{
		public const uint Id = 5576;

		public sbyte partyType;

		public double partyLeaderId;

		public sbyte maxParticipants;

		public PartyMemberInformations[] members;

		public PartyGuestInformations[] guests;

		public bool restricted;

		public string partyName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5576;
			}
		}

		public PartyJoinMessage()
		{
		}

		public PartyJoinMessage(uint partyId, sbyte partyType, double partyLeaderId, sbyte maxParticipants, PartyMemberInformations[] members, PartyGuestInformations[] guests, bool restricted, string partyName) : base(partyId)
		{
			this.partyType = partyType;
			this.partyLeaderId = partyLeaderId;
			this.maxParticipants = maxParticipants;
			this.members = members;
			this.guests = guests;
			this.restricted = restricted;
			this.partyName = partyName;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.partyType = reader.ReadSByte();
			this.partyLeaderId = reader.ReadVarUhLong();
			this.maxParticipants = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.members = new PartyMemberInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.members[i] = ProtocolTypeManager.GetInstance<PartyMemberInformations>(reader.ReadUShort());
				this.members[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.guests = new PartyGuestInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.guests[j] = new PartyGuestInformations();
				this.guests[j].Deserialize(reader);
			}
			this.restricted = reader.ReadBoolean();
			this.partyName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.partyType);
			writer.WriteVarLong(this.partyLeaderId);
			writer.WriteSByte(this.maxParticipants);
			writer.WriteShort((short)((int)this.members.Length));
			PartyMemberInformations[] partyMemberInformationsArray = this.members;
			for (int i = 0; i < (int)partyMemberInformationsArray.Length; i++)
			{
				PartyMemberInformations partyMemberInformation = partyMemberInformationsArray[i];
				writer.WriteShort(partyMemberInformation.TypeId);
				partyMemberInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.guests.Length));
			PartyGuestInformations[] partyGuestInformationsArray = this.guests;
			for (int j = 0; j < (int)partyGuestInformationsArray.Length; j++)
			{
				partyGuestInformationsArray[j].Serialize(writer);
			}
			writer.WriteBoolean(this.restricted);
			writer.WriteUTF(this.partyName);
		}
	}
}