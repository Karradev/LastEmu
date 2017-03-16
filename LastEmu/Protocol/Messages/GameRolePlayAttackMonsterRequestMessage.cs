using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayAttackMonsterRequestMessage : NetworkMessage
	{
		public const uint Id = 6191;

		public double monsterGroupId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6191;
			}
		}

		public GameRolePlayAttackMonsterRequestMessage()
		{
		}

		public GameRolePlayAttackMonsterRequestMessage(double monsterGroupId)
		{
			this.monsterGroupId = monsterGroupId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.monsterGroupId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.monsterGroupId);
		}
	}
}