using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
	{
		public const short Id = 3;

		public uint monsterId;

		public sbyte powerLevel;

		public override short TypeId
		{
			get
			{
				return 3;
			}
		}

		public GameRolePlayMutantInformations()
		{
		}

		public GameRolePlayMutantInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, string name, HumanInformations humanoidInfo, int accountId, uint monsterId, sbyte powerLevel) : base(contextualId, look, disposition, name, humanoidInfo, accountId)
		{
			this.monsterId = monsterId;
			this.powerLevel = powerLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.monsterId = reader.ReadVarUhShort();
			this.powerLevel = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.monsterId);
			writer.WriteSByte(this.powerLevel);
		}
	}
}