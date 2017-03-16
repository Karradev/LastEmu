using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
	{
		public const uint Id = 6262;

		public uint dungeonId;

		public bool[] playersDungeonReady;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6262;
			}
		}

		public PartyInvitationDungeonDetailsMessage()
		{
		}

		public PartyInvitationDungeonDetailsMessage(uint partyId, sbyte partyType, string partyName, double fromId, string fromName, double leaderId, PartyInvitationMemberInformations[] members, PartyGuestInformations[] guests, uint dungeonId, bool[] playersDungeonReady) : base(partyId, partyType, partyName, fromId, fromName, leaderId, members, guests)
		{
			this.dungeonId = dungeonId;
			this.playersDungeonReady = playersDungeonReady;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.playersDungeonReady = new bool[num];
			for (int i = 0; i < num; i++)
			{
				this.playersDungeonReady[i] = reader.ReadBoolean();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteShort((short)((int)this.playersDungeonReady.Length));
			bool[] flagArray = this.playersDungeonReady;
			for (int i = 0; i < (int)flagArray.Length; i++)
			{
				writer.WriteBoolean(flagArray[i]);
			}
		}
	}
}