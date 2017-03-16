using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
	{
		public const short Id = 159;

		public HumanInformations humanoidInfo;

		public int accountId;

		public override short TypeId
		{
			get
			{
				return 159;
			}
		}

		public GameRolePlayHumanoidInformations()
		{
		}

		public GameRolePlayHumanoidInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, string name, HumanInformations humanoidInfo, int accountId) : base(contextualId, look, disposition, name)
		{
			this.humanoidInfo = humanoidInfo;
			this.accountId = accountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.humanoidInfo = ProtocolTypeManager.GetInstance<HumanInformations>(reader.ReadUShort());
			this.humanoidInfo.Deserialize(reader);
			this.accountId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.humanoidInfo.TypeId);
			this.humanoidInfo.Serialize(writer);
			writer.WriteInt(this.accountId);
		}
	}
}