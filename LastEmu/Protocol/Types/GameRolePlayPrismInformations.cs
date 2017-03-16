using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayPrismInformations : GameRolePlayActorInformations
	{
		public const short Id = 161;

		public PrismInformation prism;

		public override short TypeId
		{
			get
			{
				return 161;
			}
		}

		public GameRolePlayPrismInformations()
		{
		}

		public GameRolePlayPrismInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, PrismInformation prism) : base(contextualId, look, disposition)
		{
			this.prism = prism;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.prism = ProtocolTypeManager.GetInstance<PrismInformation>(reader.ReadUShort());
			this.prism.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.prism.TypeId);
			this.prism.Serialize(writer);
		}
	}
}