using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaRegisterMessage : NetworkMessage
	{
		public const uint Id = 6280;

		public int battleMode;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6280;
			}
		}

		public GameRolePlayArenaRegisterMessage()
		{
		}

		public GameRolePlayArenaRegisterMessage(int battleMode)
		{
			this.battleMode = battleMode;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.battleMode = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.battleMode);
		}
	}
}