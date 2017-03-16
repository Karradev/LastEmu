using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
	{
		public const uint Id = 6245;

		public uint dungeonId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6245;
			}
		}

		public PartyInvitationDungeonRequestMessage()
		{
		}

		public PartyInvitationDungeonRequestMessage(string name, uint dungeonId) : base(name)
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