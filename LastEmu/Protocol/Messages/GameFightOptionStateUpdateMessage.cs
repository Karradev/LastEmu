using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightOptionStateUpdateMessage : NetworkMessage
	{
		public const uint Id = 5927;

		public short fightId;

		public sbyte teamId;

		public sbyte option;

		public bool state;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5927;
			}
		}

		public GameFightOptionStateUpdateMessage()
		{
		}

		public GameFightOptionStateUpdateMessage(short fightId, sbyte teamId, sbyte option, bool state)
		{
			this.fightId = fightId;
			this.teamId = teamId;
			this.option = option;
			this.state = state;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadShort();
			this.teamId = reader.ReadSByte();
			this.option = reader.ReadSByte();
			this.state = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.fightId);
			writer.WriteSByte(this.teamId);
			writer.WriteSByte(this.option);
			writer.WriteBoolean(this.state);
		}
	}
}