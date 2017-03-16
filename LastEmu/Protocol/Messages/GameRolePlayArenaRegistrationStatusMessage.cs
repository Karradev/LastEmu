using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
	{
		public const uint Id = 6284;

		public bool registered;

		public sbyte step;

		public int battleMode;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6284;
			}
		}

		public GameRolePlayArenaRegistrationStatusMessage()
		{
		}

		public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
		{
			this.registered = registered;
			this.step = step;
			this.battleMode = battleMode;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.registered = reader.ReadBoolean();
			this.step = reader.ReadSByte();
			this.battleMode = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.registered);
			writer.WriteSByte(this.step);
			writer.WriteInt(this.battleMode);
		}
	}
}