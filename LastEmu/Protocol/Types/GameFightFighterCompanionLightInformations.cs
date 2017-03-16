using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightFighterCompanionLightInformations : GameFightFighterLightInformations
	{
		public const short Id = 454;

		public sbyte companionId;

		public double masterId;

		public override short TypeId
		{
			get
			{
				return 454;
			}
		}

		public GameFightFighterCompanionLightInformations()
		{
		}

		public GameFightFighterCompanionLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, sbyte companionId, double masterId) : base(sex, alive, id, wave, level, breed)
		{
			this.companionId = companionId;
			this.masterId = masterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.companionId = reader.ReadSByte();
			this.masterId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.companionId);
			writer.WriteDouble(this.masterId);
		}
	}
}