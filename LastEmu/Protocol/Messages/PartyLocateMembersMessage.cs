using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyLocateMembersMessage : AbstractPartyMessage
	{
		public const uint Id = 5595;

		public PartyMemberGeoPosition[] geopositions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5595;
			}
		}

		public PartyLocateMembersMessage()
		{
		}

		public PartyLocateMembersMessage(uint partyId, PartyMemberGeoPosition[] geopositions) : base(partyId)
		{
			this.geopositions = geopositions;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.geopositions = new PartyMemberGeoPosition[num];
			for (int i = 0; i < num; i++)
			{
				this.geopositions[i] = new PartyMemberGeoPosition();
				this.geopositions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.geopositions.Length));
			PartyMemberGeoPosition[] partyMemberGeoPositionArray = this.geopositions;
			for (int i = 0; i < (int)partyMemberGeoPositionArray.Length; i++)
			{
				partyMemberGeoPositionArray[i].Serialize(writer);
			}
		}
	}
}