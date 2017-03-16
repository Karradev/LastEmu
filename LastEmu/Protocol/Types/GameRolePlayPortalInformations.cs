using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayPortalInformations : GameRolePlayActorInformations
	{
		public const short Id = 467;

		public PortalInformation portal;

		public override short TypeId
		{
			get
			{
				return 467;
			}
		}

		public GameRolePlayPortalInformations()
		{
		}

		public GameRolePlayPortalInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, PortalInformation portal) : base(contextualId, look, disposition)
		{
			this.portal = portal;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.portal = ProtocolTypeManager.GetInstance<PortalInformation>(reader.ReadUShort());
			this.portal.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.portal.TypeId);
			this.portal.Serialize(writer);
		}
	}
}