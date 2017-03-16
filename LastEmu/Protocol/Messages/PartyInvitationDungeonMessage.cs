using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationDungeonMessage : PartyInvitationMessage
	{
		public const uint Id = 6244;

		public uint dungeonId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6244;
			}
		}

		public PartyInvitationDungeonMessage()
		{
		}

		public PartyInvitationDungeonMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId, uint dungeonId) : base(partyId, partyType, partyName, maxParticipants, fromId, fromName, toId)
		{
			this.dungeonId = dungeonId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.dungeonId);
		}
	}
}