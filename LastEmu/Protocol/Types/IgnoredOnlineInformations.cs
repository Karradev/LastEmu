using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class IgnoredOnlineInformations : IgnoredInformations
	{
		public const short Id = 105;

		public double playerId;

		public string playerName;

		public sbyte breed;

		public bool sex;

		public override short TypeId
		{
			get
			{
				return 105;
			}
		}

		public IgnoredOnlineInformations()
		{
		}

		public IgnoredOnlineInformations(int accountId, string accountName, double playerId, string playerName, sbyte breed, bool sex) : base(accountId, accountName)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.breed = breed;
			this.sex = sex;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
			this.playerName = reader.ReadUTF();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
			writer.WriteUTF(this.playerName);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
		}
	}
}