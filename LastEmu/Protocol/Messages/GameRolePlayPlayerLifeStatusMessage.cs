using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
	{
		public const uint Id = 5996;

		public sbyte state;

		public int phenixMapId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5996;
			}
		}

		public GameRolePlayPlayerLifeStatusMessage()
		{
		}

		public GameRolePlayPlayerLifeStatusMessage(sbyte state, int phenixMapId)
		{
			this.state = state;
			this.phenixMapId = phenixMapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.state = reader.ReadSByte();
			this.phenixMapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.state);
			writer.WriteInt(this.phenixMapId);
		}
	}
}